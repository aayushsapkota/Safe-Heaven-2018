import '../../src/scss/_main.scss';
import objectFitImages from 'object-fit-images';

function ready(callback){
  // in case the document is already rendered
  if (document.readyState!='loading') callback();
  // modern browsers
  else if (document.addEventListener) document.addEventListener('DOMContentLoaded', callback);
  // IE <= 8
  else document.attachEvent('onreadystatechange', function(){
    if (document.readyState=='complete') callback();
  });
}

ready(function(){
  objectFitImages();
});
var add = document.querySelector('.side-nav');
var button = document.getElementById('collapse-btn');

var icons = document.getElementById('navbar-item');
button.addEventListener("click", evt =>{
  button.classList.toggle('rotated');
  add.classList.toggle('active');
});
