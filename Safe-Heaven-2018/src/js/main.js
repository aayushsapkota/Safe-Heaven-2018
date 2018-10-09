import '../../src/scss/_main.scss';
import objectFitImages from 'object-fit-images';
import levelManager from './levelManager';

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

  new levelManager();

});
