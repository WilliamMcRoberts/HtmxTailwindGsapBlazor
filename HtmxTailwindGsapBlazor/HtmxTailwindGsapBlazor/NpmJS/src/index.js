/* 
    This JS file is for Blazor components that have an interactive render
    mode set and you need to use ScrollTrigger. If you just need an initial
    load animation you should use tailwind classes with a timer. You can
    initialize a gsap function from the OnAfterRenderAsync lifecycle method
    to call a function from this file.
*/

import  htmx from 'htmx.org';
window.htmx = htmx;
import { gsap } from "gsap/dist/gsap";
import { ScrollTrigger } from "gsap/dist/ScrollTrigger";

gsap.registerPlugin(ScrollTrigger);

window.fly = (selector, { duration = .6, x = 0, y = 0, delay = 0, opacity = 1, ease = "power4.out", stagger = 0 }) => {
    let el = document.querySelector(selector);
    gsap.fromTo(
        el,
        { opacity: opacity, x: x, y: y },
        { opacity: 1, x: 0, y: 0, duration: duration, ease: ease, scrollTrigger: { trigger: el, start: "top bottom", stagger: stagger } }
    );
}


