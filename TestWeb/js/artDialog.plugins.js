/*!
* artDialog 5 plugins
* Date: 2012-02-25
* http://code.google.com/p/artdialog/
* (c) 2009-2012 TangBin, http://www.planeArt.cn
*
* This is licensed under the GNU LGPL, version 2.1 or later.
* For details, see: http://creativecommons.org/licenses/LGPL/2.1/
*/

;(function ($) {

/**
 * 警告
 * @param   {String, HTMLElement}   消息内容
 * @param   {Function}              (可选) 回调函数
 */
$.alert = function (content, callback) {
    return $.dialog({
        id: 'Alert',
        fixed: true,
        lock: true,
        content: content,
        ok: true,
        beforeunload: callback
    });
};


/**
 * 确认选择
 * @param   {String, HTMLElement}   消息内容
 * @param   {Function}              确定按钮回调函数
 * @param   {Function}              取消按钮回调函数
 */
$.confirm = function (content, ok, cancel) {
    return $.dialog({
        id: 'Confirm',
        fixed: true,
        lock: true,
        content: content,
        ok: ok,
        cancel: cancel
    });
};


/**
 * 输入框
 * @param   {String, HTMLElement}   消息内容
 * @param   {Function}              确定按钮回调函数。函数第一个参数接收用户录入的数据
 * @param   {String}                输入框默认文本
 */
$.prompt = function (content, ok, defaultValue) {
    defaultValue = defaultValue || '';
    var input;
    
    return $.dialog({
        id: 'Prompt',
        fixed: true,
        lock: true,
        content: [
            '<div style="margin-bottom:5px;font-size:12px">',
                content,
            '</div>',
            '<div>',
                '<input type="text" class="d-input-text" value="',
                    defaultValue,
                '" style="width:18em;padding:6px 4px" />',
            '</div>'
            ].join(''),
        initialize: function () {
            input = this.dom.content.find('.d-input-text')[0];
            input.select();
            input.focus();
        },
        ok: function () {
            return ok && ok.call(this, input.value);
        },
        cancel: function () {}
    });
};


/** 抖动效果 */
$.dialog.prototype.shake = function () {

    var fx = function (ontween, onend, duration, easing) {
        var startTime = + new Date;
        var timer = setInterval(function () {
            var runTime = + new Date - startTime;
            var pre = runTime / duration;
                
            if (pre >= 1) {
                clearInterval(timer);
                onend(pre);
            } else {
                ontween(
                    easing
                    ? easing(pre, runTime, 0, 1, duration)
                    : pre
                   );
            };
        }, 13);
    };
    
    var animate = function (elem, distance, duration) {
        var quantity = arguments[3];

        if (quantity === undefined) {
            quantity = 12;
            duration = duration / quantity;
        };
        
        var style = elem.style;
        var from = parseInt(style.marginLeft) || 0;
        
        fx(function (pre) {
            elem.style.marginLeft = from + (distance - from) * pre + 'px';
        }, function () {
            if (quantity !== 0) {
                animate(
                    elem,
                    quantity === 1 ? 0 : distance / quantity - distance,
                    duration,
                    -- quantity
                );
            };
        }, duration, function (x, t, b, c, d) {
            if ((t/=d/2) < 1) return c/2*t*t + b;
            return -c/2 * ((--t)*(t-2) - 1) + b;
        });
    };
    
    animate(this.dom.wrap[0], 20, 600);
    
    return this;
};


// 拖拽支持
var DragEvent = function () {
    var that = this,
        proxy = function (name) {
            var fn = that[name];
            that[name] = function () {
                return fn.apply(that, arguments);
            };
        };
        
    proxy('start');
    proxy('move');
    proxy('end');
};

$.noop = $.noop || function () {}; // < 1.42

DragEvent.prototype = {

    // 开始拖拽
    onstart: $.noop,
    start: function (event) {
        $(document)
        .bind('mousemove', this.move)
        .bind('mouseup', this.end);
            
        this._sClientX = event.clientX;
        this._sClientY = event.clientY;
        this.onstart(event.clientX, event.clientY);

        return false;
    },
    
    // 正在拖拽
    onmove: $.noop,
    move: function (event) {		
        this._mClientX = event.clientX;
        this._mClientY = event.clientY;
        this.onmove(
            event.clientX - this._sClientX,
            event.clientY - this._sClientY
        );
        
        return false;
    },
    
    // 结束拖拽
    onend: $.noop,
    end: function (event) {
        $(document)
        .unbind('mousemove', this.move)
        .unbind('mouseup', this.end);
        
        this.onend(event.clientX, event.clientY);
        return false;
    }
    
};

var $window = $(window),
    $document = $(document),
    html = document.documentElement,
    isIE6 = !('minWidth' in html.style),
    isLosecapture = 'onlosecapture' in html,
    isSetCapture = 'setCapture' in html;
    
var dragInit = function (event) {
    
    var dragEvent = new DragEvent;
    var limit, startWidth, startHeight, startLeft, startTop,
        api = artDialog.focus,
        dom = api.dom,
        wrap = dom.wrap,
        title = dom.title,
        main = dom.main;
        
    var isResize = event.target === dom.se[0] ? true : false;

        
    // 清除文本选择
    var clsSelect = 'getSelection' in window
    ? function () {
        window.getSelection().removeAllRanges();
    }
    : function () {
        try {
            document.selection.empty();
        } catch (e) {};
    };
    
    
    // 对话框准备拖动
    dragEvent.onstart = function (x, y) {
    
        if (isResize) {
            startWidth = main[0].offsetWidth;
            startHeight = main[0].offsetHeight;
        } else {
            startLeft = wrap[0].offsetLeft;
            startTop = wrap[0].offsetTop;
        };
        
        $document.bind('dblclick', dragEvent.end);
            
        if (!isIE6 && isLosecapture) {
            title.bind('losecapture', dragEvent.end)
        } else {
            $window.bind('blur', dragEvent.end)
        };
            
        isSetCapture && title[0].setCapture();
        
        wrap.addClass('d-state-drag');
        api.focus();
    };
    
    // 对话框拖动进行中
    dragEvent.onmove = function (x, y) {
    
        if (isResize) {
            var wrapStyle = wrap[0].style,
                style = main[0].style,
                width = x + startWidth,
                height = y + startHeight;
            
            wrapStyle.width = 'auto';
            style.width = Math.max(0, width) + 'px';
            wrapStyle.width = wrap[0].offsetWidth + 'px';
            
            style.height = Math.max(0, height) + 'px';
            
        } else {
            var style = wrap[0].style,
                left = Math.max(limit.minX, Math.min(limit.maxX, x + startLeft)),
                top = Math.max(limit.minY, Math.min(limit.maxY, y + startTop));

            style.left = left  + 'px';
            style.top = top + 'px';
        };
            
        clsSelect();
        
    };
    
    // 对话框拖动结束
    dragEvent.onend = function (x, y) {
    
        $document.unbind('dblclick', dragEvent.end);
        
        if (!isIE6 && isLosecapture) {
            title.unbind('losecapture', dragEvent.end);
        } else {
            $window.unbind('blur', dragEvent.end)
        };
        
        isSetCapture && title[0].releaseCapture();
        
        wrap.removeClass('d-state-drag');
    };
    
    
    limit = (function () {
    
        var maxX, maxY,
            wrap = api.dom.wrap[0],
            fixed = wrap.style.position === 'fixed',
            ow = wrap.offsetWidth,
            oh = wrap.offsetHeight,
            ww = $window.width(),
            wh = $window.height(),
            dl = fixed ? 0 : $document.scrollLeft(),
            dt = fixed ? 0 : $document.scrollTop(),
            
        // 坐标最大值限制
        maxX = ww - ow + dl;
        maxY = wh - oh + dt;
        
        return {
            minX: dl,
            minY: dt,
            maxX: maxX,
            maxY: maxY
        };
        
    })();
    
    dragEvent.start(event);
    
};


// 代理 mousedown 事件触发对话框拖动
$(document).bind('mousedown', function (event) {
    var api = artDialog.focus;
    if (!api) return;

    var target = event.target,
        config = api.config,
        dom = api.dom;
    
    if (config.drag !== false && target === dom.title[0]
    || config.resize !== false && target === dom.se[0]) {
        dragInit(event);
        return false;// 防止firefox与chrome滚屏
    };
});


}(this.art || this.jQuery, this));

