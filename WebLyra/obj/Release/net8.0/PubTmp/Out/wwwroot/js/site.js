// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function AnimationButtonSent(divId, spanId) {
	var div = document.getElementById(divId);
	var span = document.getElementById(spanId);
	span.style.display = 'none';
	div.style.display = '';
}
function AnimationButtonClose(divId, spanId) {
	var div = document.getElementById(divId);
	var span = document.getElementById(spanId);
	span.style.display = '';
	div.style.display = 'none';
}
