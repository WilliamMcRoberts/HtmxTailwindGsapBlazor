import { animateSlideRight } from "/js/hooks.js"; 

export function onLoad() {
    console.log("Loaded / Home...")
    animateSlideRight();
    const els = document.querySelectorAll(".process-home");
    els.forEach((el) => {
        console.log("Processing onLoad / Home.razor.js", el.tagName)
        htmx.process(el);
    })
}

export function onUpdate() {
    console.log("Updated / H...")
}

export function onDispose() {
    console.log("Disposed / Home...")
}
