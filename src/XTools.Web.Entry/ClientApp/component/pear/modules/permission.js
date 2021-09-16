layui.define(['jquery','context','popup'], function(exports) {
	"use strict";

	var MOD_NAME = 'permission',
		$ = layui.jquery,
		popup = layui.popup,
		context = layui.context;

	var permission = new function() {}
	
	var curWwwPath = window.document.location.href;
	var pathName = window.document.location.pathname;
	var pos = curWwwPath.indexOf(pathName);
	var localhostPath = curWwwPath.substring(0, pos);
	var projectName = pathName.substring(0, pathName.substr(1).indexOf('/') + 1);
	var basePath=localhostPath+projectName+"/";
		
	if(context.get("token") == null || context.get("token") == undefined){
		popup.failure("暂未认证，请前往登录",function(){
			top.location.href = basePath+'login.html';
		})
	}
	
	$.ajaxSetup({
		dataType: "json",
		cache: false,
	    headers: {
	        "Authorization": context.get("token")
	    },
	    complete: function(xhr) {
	        if(xhr.responseJSON.statusCode == 401){
				popup.failure("暂未认证，请前往登录",function(){
					top.location.href = basePath+'login.html';
				})
	        }
	    }
	});
	
	exports(MOD_NAME, permission);
});
