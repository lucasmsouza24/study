$(document).ready(function(){
	$("#right").click(function(){
		var player = $("#player");
		player.animate({left: '+=50px'});
	});
	$("#left").click(function(){
		var player = $("#player");
		player.animate({left: '-=50px'});
	});
	$("#up").click(function(){
		var player = $("#player");
		player.animate({top: '-=50px'});
		console.log("func")
	});
	$("#down").click(function(){
		var player = $("#player");
		player.animate({top: '+=50px'});
	});
});
