$(function(){
	$('.navbar-nav li:nth-child(2) a').click(function(){
		$('body').animation({scrollTop:900});
		return false;
	})
})