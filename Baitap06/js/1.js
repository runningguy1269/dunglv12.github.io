$(function(){
	$(window).scroll(function(){
		vitrihientai = $('html').scrollTop();
		console.log(vitrihientai);

		if(vitrihientai > 337)
		{
			$('.navbar-expand-lg').addClass('tienhoa');
		}
		else if(vitrihientai == 0)
		{
			$('.navbar-expand-lg').removeClass('tienhoa');
		}

		//mo rong
		if(vitrihientai > 500)
		{
			$('.nen3').addClass('bienra');
		}
		else
		{
			$('.nen3').removeClass('bienra');
		}
	})

	$('.n1').click(function(){
		$('html').animate({scrollTop:$('.nen3').offset().top},800);
	})
	$('.n2').click(function(){
		$('html').animate({scrollTop:$('.nen4').offset().top},800);
	})
	$('.n3').click(function(){
		$('html').animate({scrollTop:$('.contactme').offset().top},800);
	})
})