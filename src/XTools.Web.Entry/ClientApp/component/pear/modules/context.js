layui.define(['jquery', 'element'], function(exports) {
	"use strict";

	var MOD_NAME = 'context',
		$ = layui.jquery,
		element = layui.element;

	var context = new function() {
		
		this.put = function(key,value){
			localStorage.setItem(key,value);
		}

		this.get = function(key){
			return localStorage.getItem(key);
		}
		
		localStorage.setItem("base-path","");
	}
	exports(MOD_NAME, context);
});
