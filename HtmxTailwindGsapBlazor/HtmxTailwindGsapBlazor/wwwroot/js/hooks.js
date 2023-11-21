

// Hooks for Blazor Enhanced Load and htmx / use for IntersectionObserver animations

//let el = document.getElementById('scroll');

window.onload = () => {
    console.log("window.onload() from hooks.js")
    animateSlideRight()
}

//window.onscroll = () => {
//    console.log("Scroll Y from hooks.js: ", window.scrollY);
//    el.style.fontSize = `${window.scrollY}px`;
//}

function animateSlideRight() {
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

Blazor.addEventListener('enhancedload', () => {
    //el = document.getElementById('scroll')
    console.log("Enhanced Load from hooks.js")
    animateSlideRight()
    const els = document.querySelectorAll(".process");
    els.forEach((el) => {
        console.log("Processing enhanceLoad / module.js", el.tagName)
        htmx.process(el);
    })
});


///////////////////////////////////////////////////////////////////////////////////////////////////////////////