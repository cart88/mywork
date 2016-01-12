$(function(){
	setHeight();
	$("#switch_go").click(toggleMenu);
	setTime();
	formatMenu();
	
	$(window).resize(setHeight);
	$(window).keydown(function(e) {
		//$("#ttt").html($("#ttt").html() + "<br />" + String.fromCharCode(e.keyCode) + "|" + e.keyCode);		
		if(e.keyCode==186){
			window.keyStr = "";
		}else if(e.keyCode==16){
			alert(window.keyStr)
		}else{
			window.keyStr += String.fromCharCode(e.keyCode);
		}
	});
})


function setHeight(){
	var window_height = $(window).height();
	var top_height = 102;
	$("#main_table").height(window_height - top_height);
	$("#switch_go").css("margin-top",((window_height - top_height - 42)/2) + "px");
	$("#main_iframe").height(window_height - top_height);
	$("#menu_div").height(window_height - top_height -28);
}


var menuHide = false;
function toggleMenu(){
	if(menuHide){
		$("#menu").show();
		$("#switch_go").removeClass("back");
	}else{
		$("#menu").hide();
		$("#switch_go").addClass("back");
	}
	menuHide = !menuHide;
}

function setTime(){ 
	var day=""; 
	var month=""; 
	var ampm=""; 
	var ampmhour=""; 
	var myweekday=""; 
	var year=""; 
	var myHours=""; 
	var myMinutes=""; 
	var mySeconds=""; 
	mydate=new Date(); 
	myweekday=mydate.getDay(); 
	mymonth=mydate.getMonth()+1; 
	myday= mydate.getDate(); 
	myyear= mydate.getYear(); 
	myHours = mydate.getHours(); 
	myMinutes = mydate.getMinutes(); 
	mySeconds = mydate.getSeconds();
	myHours = parseInt(myHours)<10?"0"+myHours:myHours;
	myMinutes = parseInt(myMinutes)<10?"0"+myMinutes:myMinutes;
	mySeconds = parseInt(mySeconds)<10?"0"+mySeconds:mySeconds;
	year=(myyear > 200) ? myyear : 1900 + myyear; 
	
	if(myweekday == 0){
		weekday="星期日";
	}else if(myweekday == 1){
		weekday="星期一"; 
	}else if(myweekday == 2){
		weekday="星期二"; 
	}else if(myweekday == 3){
		weekday="星期三"; 
	}else if(myweekday == 4){
		weekday="星期四"; 
	}else if(myweekday == 5){
		weekday="星期五"; 
	}else if(myweekday == 6){
		weekday="星期六"; 
	}
	$("#top_times").html(year + "年" + mymonth + "月" + myday + "日&nbsp;" + weekday + "&nbsp;现在时间：" + myHours + ":" + myMinutes + ":" + mySeconds); 
	setTimeout("setTime()",1000); 
}


var this_menu=null;
function formatMenu(){
	//menu_all
	$("#menu_all dl").each(function(index,element){
		$(this).find("dt").click(function(){
			if(this_menu!=null){
				$(this_menu).next("dd").slideUp("fast");
				$(this_menu).parent().removeClass("open");
			}
			if(this_menu!=this){
				$(this).next("dd").slideDown("fast");
				$(this).parent().addClass("open");
				this_menu = this;
			}else{
				this_menu = null;
			}
		});
		$(this).find("dd").hide();
	});
	$("#menu_all dl dd ul li").hover(
	function(){
		$(this).addClass("this");
	},
	function(){
		$(this).removeClass("this");
	});
}