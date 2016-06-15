// JavaScript Document

function pwd_retrieve(obj){
	var index_no = $(obj).parents('dd').index();
	var tit = $(obj).parents('dd').siblings('dt').children('strong');
	
	$(obj).parents('dd').hide().next('dd').show();
	
	$(tit).eq(index_no-2).find('i').removeClass('iconG05_6_3').addClass('iconG05_6_4');
	$(tit).eq(index_no-1).find('i').removeClass('iconG05_6_1').addClass('iconG05_6_3');
	$(tit).eq(index_no-1).addClass('off');
	
	$(tit).eq(index_no).find('i').removeClass('iconG05_6_2').addClass('iconG05_6_1');
	$(tit).eq(index_no).addClass('on');
}

//《中国回收商网服务协议》
$(function(){
	$('.agreement').click(function(){
		$('.agreement_box').slideToggle(100);
		$('html, body').animate({scrollTop: $(document).height()}, 'slow'); 
	})	
})

//banner
$(function(){
	var numpic = $('#slides li').size()-1;
	var nownow = 0;
	var inout = 0;
	var TT = 0;
	var SPEED = 5000;


	$('#slides li').eq(0).siblings('li').css({'display':'none'});
	
	var pagina = $('#pagination');;
	var pagination = $('#pagination li');
	var paginationwidth = $('#pagination').width();
	pagination.eq(0).addClass('on')
		
	function  pagina(){
		//var lilicount = numpic + 1;
		for(var i = 0; i <= numpic; i++){
			ulcontent += '<li>' + (i+1) + '</li>';
		}
		
		$('#slides').after('#pagination li');	
	}

	pagination.on('click',DOTCHANGE)
	
	function DOTCHANGE(){
		
		var changenow = $(this).index();
		
		$('#slides li').eq(nownow).css('z-index','900');
		$('#slides li').eq(changenow).css({'z-index':'800'}).show();
		pagination.eq(changenow).addClass('on').siblings('li').removeClass('on');
		$('#slides li').eq(nownow).fadeOut(400,function(){$('#slides li').eq(changenow).fadeIn(500);});
		nownow = changenow;
	}
	
	pagination.mouseenter(function(){
		inout = 1;
	})
	
	pagination.mouseleave(function(){
		inout = 0;
	})
	
	function GOGO(){
		
		var NN = nownow+1;
		
		if( inout == 1 ){
			} else {
			if(nownow < numpic){
			$('#slides li').eq(nownow).css('z-index','900');
			$('#slides li').eq(NN).css({'z-index':'800'}).show();
			pagination.eq(NN).addClass('on').siblings('li').removeClass('on');
			$('#slides li').eq(nownow).fadeOut(400,function(){$('#slides li').eq(NN).fadeIn(500);});
			nownow += 1;

		}else{
			NN = 0;
			$('#slides li').eq(nownow).css('z-index','900');
			$('#slides li').eq(NN).stop(true,true).css({'z-index':'800'}).show();
			$('#slides li').eq(nownow).fadeOut(400,function(){$('#slides li').eq(0).fadeIn(500);});
			pagination.eq(NN).addClass('on').siblings('li').removeClass('on');

			nownow=0;

			}
		}
		TT = setTimeout(GOGO, SPEED);
	}
	
	TT = setTimeout(GOGO, SPEED); 

})

//login page
$(function(){
	var vd_account = $('.sign .zi .account input').attr('value');
	$('.sign .zi .account input').focus(function(){
		if($(this).attr('value')==vd_account){$(this).attr('value','').css({'color':'#333'});}
	}).blur(function(){
		if($(this).attr('value')==''){$(this).attr('value',vd_account).css({'color':'#ccc'});}	
	})
	$('.sign .zi .pw #pw1').focus(function(){
		$(this).css({'display':'none'});
		$('.sign .zi .pw #pw2').css({'display':''}).focus();
	})
	$('.sign .zi .pw #pw2').blur(function(){
		if(!$(this).attr('value')){
			$(this).css({'display':'none'});
			$('.sign .zi .pw #pw1').css({'display':''});
		}
	})
	
	$('.sign .btn_login input').hover(function(){$(this).addClass('active');},function(){$(this).removeClass('active');})
})