//import {observeSlideRight, animateSlideRight } from '/js/hooks.js';

export function onLoad() {
    console.log("Loaded / Home...");
    animateSlideRight();
    observeSlideRight();
    let el = document.getElementById('scroll');
    window.onscroll = () => {
        console.log("Scroll Y from index.js: ", window.scrollY);
        el.style.transform = `translateY(${window.scrollY * 1.15}px)`;
    }

}

export function onUpdate() {
    console.log("Updated / Home...");
}

export function onDispose() {
    console.log("Disposed / Home...");
}

