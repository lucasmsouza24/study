let listElement = document.querySelector("#app ul");
let inputElement = document.querySelector("#app input");
let buttonElement = document.querySelector("#app button");

let todos = [
    "Fazer café",
    "Estudar",
    "Dormir"
]

let renderTodos = () => {
    for(i in todos) {
        console.log(i);
    }
}

renderTodos();