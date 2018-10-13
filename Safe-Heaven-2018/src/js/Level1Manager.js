import swal from 'sweetalert2';

class Level1Manager {

  constructor(options) {
    let defaults = {
      btn: '.school',
      browserClass: '.browser',
      downloadBtnClass: '.browser__download',
      modalClass: '.modal',
      modalOpenClass: 'modal--open',
      hiddenClass: 'hidden'
    };

    let populated = Object.assign(defaults, options);
    for (let key in populated) {
      if (populated.hasOwnProperty(key)) {
        this[key] = populated[key];
      }
    }

    this.start(this);
  }

  start(obj) {

    let btn =  document.querySelector(obj.btn);

    btn.addEventListener("click", (e) => {
      e.preventDefault();
      let browser = document.querySelector(obj.browserClass);
      browser.classList.remove(obj.hiddenClass);
    });

    let downloadBtn = document.querySelector(obj.downloadBtnClass);
    console.log(downloadBtn);
    downloadBtn.addEventListener("click", (e) => {
      e.preventDefault();
      swal(
        'Warning!',
        'Downloading games from online sites can be dangerous',
        'warning'
      );
      let browser = document.querySelector(obj.browserClass);
      browser.classList.add(obj.hiddenClass);
      btn.innerHTML = '<div class="container"><h2>Lesson learned: Never download games from unsafe sites</h2> <a href="/Game/Mall" class="btn btn-warning">Next level</a></div>'; 

    });



  }
};

export default Level1Manager;
