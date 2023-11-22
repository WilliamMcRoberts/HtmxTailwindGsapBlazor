export function onLoad() {
    console.log("Loaded / Weather...")
    let w = document.querySelector(".fly-weather");
    w.animate({ opacity: [0, 1], transform: ["translateX(-50px)", "translateX(0)"] }, { duration: 600, easing: 'ease-out', fill: 'forwards', delay: 0 })
}
export function onUpdate() {
    console.log("Updated / W...")
}

export function onDispose() {
    console.log("Disposed / Weather...")
}
