
// Hooks for Blazor Enhanced Load and htmx / use for IntersectionObserver animations


//window.onload = () => {
//    console.log("window.onload() from hooks.js")
//    animateSlideRight()
//}


window.observeSlideRight = () => {
    const els = document.querySelectorAll(".observe-slide-right");
    if (!els || els.length < 1) return;
    const elArray = Array.from(els);
    let observer = new IntersectionObserver((entries) => {
        entries.map((entry) => {
            if (entry.isIntersecting) {
                entry.target.animate({ opacity: [0, 1], transform: ["translateX(-50px)", "translateX(0)"] }, { duration: 600, easing: 'ease-out', fill: 'forwards', delay: 0 })
                observer.unobserve(entry.target);
            }
        })
    })
    elArray.forEach((el) => {
        observer.observe(el);
    })
}

window.animateSlideRight = () =>{
    const animEls = document.querySelectorAll(".anim-slide-right");
    if (!animEls || animEls.length < 1) return;
    console.log("Els from Animate: ", animEls);
    animEls.forEach((el) => {
        console.log("el: ", el);
        el.animate({ opacity: [0, 1], transform: ["translateX(-50px)", "translateX(0)"] }, { duration: 600, easing: 'ease-out', fill: 'forwards', delay: 0 })
    });
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////