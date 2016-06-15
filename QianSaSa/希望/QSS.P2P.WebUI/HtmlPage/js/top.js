// JavaScript Document

$(document).ready(function(){
	topEffect();
})

/* ------------------------------------------------
 * top part
 * ------------------------------------------------ */
function topEffect(){
	
	var top_fr,li_service,li_sort,li_map,li_help,li_qq,li_release;
	
	$li_service = $("<li class='service'><a class='nav_title' href='/huishoushang/html/vip/index2.html'><span>财富通服务</span><i class='iconG01 iconG01_4_1'></i></a><div class='popbox'><a href='/huishoushang/html/vip/service.html'>财富通介绍</a><a href='/huishoushang/html/vip/apply.html'>财富通申请</a><a rel='nofollow' href='javascript:void(0)'>400-707-9877</a></div></li>");
	
	$li_sort = $("<li class='sort'><a class='nav_title' href='javascript:void(0)'><span>地方分站</span><i class='iconG01 iconG01_4'></i></a><dl><dd><h3>地区分站</h3><div><a href='/huishoushang/html/views/region/beijing.html' target='_blank'>北京</a> <a href='#' target='_blank'>天津</a> <a href='#' target='_blank'>河北</a> <a href='#' target='_blank'>山西</a> <a href='#' target='_blank'>内蒙古</a> <a href='#' target='_blank'>辽宁</a> <a href='#' target='_blank'>吉林</a> <a href='#' target='_blank'>黑龙江</a> <a href='#' target='_blank'>上海</a> <a href='#' target='_blank'>江苏</a> <a href='#' target='_blank'>浙江</a> <a href='#' target='_blank'>安徽</a> <a href='#' target='_blank'>福建</a> <a href='#' target='_blank'>江西</a> <a href='#' target='_blank'>山东</a> <a href='#' target='_blank'>河南</a> <a href='#' target='_blank'>湖北</a> <a href='#' target='_blank'>湖南</a> <a href='#' target='_blank'>广东</a> <a href='#' target='_blank'>广西</a> <a href='#' target='_blank'>海南</a> <a href='#' target='_blank'>重庆</a> <a href='#' target='_blank'>四川</a> <a href='#' target='_blank'>贵州</a> <a href='#' target='_blank'>云南</a> <a href='#' target='_blank'>陕西</a> <a href='#' target='_blank'>甘肃</a> <a href='#' target='_blank'>新疆</a> </div></dd><dd><h3>行业分站</h3><div><a href='/huishoushang/html/views/hangye/index.html' target='_blank'>化工设备网</a> <a href='#' target='_blank'>机床设备网</a> <a href='#' target='_blank'>纺织设备网</a> <a href='#' target='_blank'>制冷设备网</a> <a href='#' target='_blank'>电力设备网</a> <a href='#' target='_blank'>印刷设备网</a> <a href='#' target='_blank'>木工设备网</a> <a href='#' target='_blank'>造纸设备网</a> <a href='#' target='_blank'>水泥设备网</a> <a href='/huishoushang/html/views/feisuliao/index.html' target='_blank'>塑料设备网</a> <a href='#' target='_blank'>备品备件网</a> <a href='#' target='_blank'>服装设备网</a></div></dd></dl></li>");
	
	$li_map = $("<li class='map'><a class='nav_title' href='/huishoushang/html/other/map.html'><span>网站地图</span><i class='iconG01 iconG01_4_1'></i></a><div class='popbox'><dl class='n1'><dt>二手设备</dt><dd><a href='/huishoushang/html/views/hangye/index.html'>化工设备网</a><a href='#'>制冷设备网</a><a href='#'>木工设备网</a><a href='#'>机床设备网</a><a href='#'>电力设备网</a><a href='#'>印刷设备网</a><a href='#'>造纸设备网</a><a href='#'>水泥设备网</a><a href='#'>纺织设备网</a><a href='/huishoushang/html/views/feisuliao/index.html'>塑料设备网</a><a href='#'>备品备件网</a><a href='#'>服装设备网</a></dd></dl><dl class='n2'><dt>其它设备</dt><dd><a href='#'>发电机</a><a href='#'>电动机</a><a href='#'>轴承</a><a href='#'>变压器</a><a href='#'>压缩机</a><a href='#'>锅炉</a><a href='#'>注塑机</a><a href='#'>绣花机</a><a href='#'>食品</a><a href='#'>冶金</a><a href='#'>金属</a><a href='#'>不锈钢</a><a href='#'>废铜</a><a href='#'>农业</a><a href='#'>电子</a><a href='#'>废橡胶</a><a href='#'>塑料</a><a href='#'>包装</a><a href='#'>库存</a><a href='#'>生产线</a><a href='#'>拆迁</a></dd></dl><dl class='n3'><dt>地方分站</dt><dd><a class='hot' href='/huishoushang/html/views/region/beijing.html'>北京</a><a class='hot' href='#'>天津</a><a class='hot' href='#'>上海</a><a class='hot' href='#'>重庆</a><a class='hot' href='#'>上海</a><br /><a href='#'>河北</a><a href='#'>山西</a><a href='#'>山东</a><a href='#'>福建</a><a href='#'>浙江</a><a href='#'>江苏</a><a href='#'>河南</a><a href='#'>内蒙古</a><a href='#'>吉林</a><a href='#'>辽宁</a><a href='#'>安徽</a><a href='#'>宁夏</a><a href='#'>新疆</a><a href='#'>西藏</a><a href='#'>贵州</a><a href='#'>云南</a><a href='#'>四川</a><a href='#'>广西</a><a href='#'>广东</a><a href='#'>黑龙江</a><a href='#'>陕西</a><a href='#'>甘肃</a><a href='#'>海南</a><a href='#'>江西</a><a href='#'>湖北</a><a href='#'>湖南</a></dd></dl><dl class='n4'><dt>定制服务</dt><dd><strong><a target='_blank' href='/huishoushang/html/vip/index2.html'>财富通</a></strong><p class='mb10'><a target='_blank' href='#'>企业旺铺</a><a target='_blank' href='#'>黄金展位</a><br /><a target='_blank' href='#'>固定排名</a><a target='_blank' href='/huishoushang/html/adv/index.html'>广告服务</a></p><div><a target='_blank' href='/huishoushang/html/minglu/index.html'>商人名录</a> | <a target='_blank' href='/huishoushang/html/guibin/index.html'>贵宾专区</a> | <a target='_blank' href='/huishoushang/html/renwu/index.html'>人物</a></div><p class='mt10'><a href='#'><i class='iconG01 iconG01_9 mr5'></i>新浪微博</a><a href='#'><i class='iconG01 iconG01_10 mr5'></i>腾讯微博</a></p></dd></dl><div class='cb'></div><div class='model'><a class='modfr newblock' href='/huishoushang/html/jifen/index.html'>积分商城</a><a target='_blank' href='/huishoushang/html/views/jinshu/index.html'>废金属网</a><a target='_blank' href='/huishoushang/html/views/suliao/index.html'>废塑料网</a><a  target='_blank' href='/huishoushang/html/views/feizhi/index.html'>废纸网</a><a target='_blank' href='/huishoushang/html/views/feiliao/index.html'>化工废料网</a><a  target='_blank' href='/huishoushang/html/views/wuzi/index.html'>废旧物资网</a></div></div></li>");
	
	$li_help = $("<li><a style='padding:0 5px;' href='/huishoushang/html/help/index.html'>帮助中心</a></li>");
	
	$li_qq = $("<li class='qq'><div class='innner'><a class='nav_title' href='#'><span>在线客服</span><i class='iconG01 iconG01_4_1'></i></a><div class='popbox'><a href='#'><i class='iconG01 iconG01_1'></i></a><a href='#'><i class='iconG01 iconG01_1'></i></a><a href='#'><i class='iconG01 iconG01_2'></i></a><a href='#'><i class='iconG01 iconG01_1'></i></a><a href='#'><i class='iconG01 iconG01_1'></i></a><a href='#'><i class='iconG01 iconG01_1'></i></a><i class='iconG01 iconG01_8'></i></div></div></li>");
	
	$li_release = $("<li><a style='padding:0 5px;' target='_blank' class='fontC04' href='/huishoushang/html/views/quick/index.html'>发布信息</a></li>");
	
	$home_page = $("<li><a style='padding:0 5px;' class='fontC04' href='/huishoushang/html/index/index.html'>回收商网首页</a></li>");
	
	$top_fr = $("<div class='fr'><ul></ul></div>");
	
	$(".topInner .fl").after($top_fr);
	
	$(".topInner .fr ul").append($li_map).append($li_qq).append($li_help).append($li_service).append($li_release).append($home_page);
	
	$('#top li.map .popbox dl:last').css({'border-right':'0'});
	//$('#top li.map .popbox .model a:first').css({'border-left':'0','width':'206px'});
	
	$('#top li').hover(
		function(){
			$(this).find('.iconG01_4_1').addClass('iconG01_4_2');
		},
		function(){
			$(this).find('.iconG01_4_1').removeClass('iconG01_4_2');
		}
	)
		
	$('#top li.service').hover(
		function(){
			$(this).addClass('on').children('div').slideDown(200);
		},
		function(){
			$(this).removeClass('on').children('div').slideUp(200);
		}
	)
	
	$('#top li.qq').hover(
		function(){
			$(this).addClass('on');
			$(this).find('.popbox').slideDown(100);
		},
		function(){
			$(this).removeClass('on');
			$(this).find('.popbox').slideUp(100);
		}
	)
	
	$('#top .weixin').hover(
		function(){
			$(this).find('div').addClass('on');
			$(this).find('div p').slideDown(100);
		},
		function(){
			$(this).find('div').removeClass('on');
			$(this).find('div p').slideUp(100);
		}
	)
	
	$('#top .user').hover(
		function(){
			$(this).addClass('on');
			$(this).find('.userbox').slideDown(100);
		},
		function(){
			$(this).removeClass('on');
			$(this).find('.userbox').slideUp(100);
		}
	)
	
	$('#top .topInner').append("<span class='tipText'><i></i>多种登录形式<em></em></span>");
	$('#top .tipText').find('em').click(function(){$(this).parents('.tipText').hide(100);})
	$('#top .loginway').hover(
		function(){
			$(this).addClass('on');
			$(this).find('.popbox').slideDown(100);
		},
		function(){
			$(this).removeClass('on');
			$(this).find('.popbox').slideUp(100);
		}
	)
	
	$('#top .map').hover(
		function(){
			$(this).addClass('on');
			$(this).find('.popbox').slideDown(100);
		},
		function(){
			$(this).removeClass('on');
			$(this).find('.popbox').slideUp(100);
		}
	)
}
/* ------------------------------------------------
 * top_fix_search
 * ------------------------------------------------ */
$(function(){
	$('#top_fix_search .sBpart .ptop a:first').addClass('on');
	$('#top_fix_search .sBpart .ptop a').click(function(){
		$(this).addClass('on').siblings().removeClass('on');	
	})
})
function top_fix_search(){
	$(window).scroll(function(){
		if($(document).scrollTop() > 200){
			$('#top_fix_search').css({'display':'block'});
		}
		else{
			$('#top_fix_search').css({'display':'none'});
		}
	})	
}