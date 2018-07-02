document.addEventListener("DOMContentLoaded", function() {
    var element = document.createElement("p");
    var text = document.createTextNode("This is the element from the (modified) js1 file");
    element.appendChild(text);
    document.body.appendChild(element);
});