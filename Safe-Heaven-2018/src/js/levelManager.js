module.exports = class levelManager {

  constructor(options) {
    let defaults = {
      nextBtn: '.level1__next',
      levelSectionClass: '.level__section',
      hiddenClass: 'hidden'
    };

    let populated = Object.assign(defaults, options);
    for (let key in populated) {
      if (populated.hasOwnProperty(key)) {
        this[key] = populated[key];
      }
    }

    this.next(this);
  }

  next(that) {
    console.log("running");
    let nextBtns = document.querySelectorAll(that.nextBtn);
    let levelSections = document.querySelectorAll(that.levelSectionClass);
    if (nextBtns) {
      // console.log("inside");
      let levelSectionsSize = levelSections.length;
      for (let i = 0; i < nextBtns.length; i++) {
        console.log(nextBtns[i]);


        nextBtns[i].addEventListener("click", function(event) {
          let currentlevelSection = event.target.parentNode.parentNode;

          //hiding current section
          currentlevelSection.classList.add(that.hiddenClass);
          console.log(currentlevelSection);

          var nextIndex = i + 1;
          var nextLevelSection = null;
          if (nextIndex < levelSectionsSize) {
            nextLevelSection = levelSections[i + 1];
          } else {
            nextLevelSection = levelSections[i];
          }

          currentlevelSection.classList.add(that.hiddenClass);
          nextLevelSection.classList.remove(that.hiddenClass);

        });

      }
    }
  }
};
