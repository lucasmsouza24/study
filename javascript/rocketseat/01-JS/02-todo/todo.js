// create and add new to do
let addTodo = () => {
    // get todo values
    elementInput = document.querySelector('#inputTodo');
    todoText = elementInput.value;

    // create new todo
    let li = document.createElement('li');
    let label = document.createElement('label');
    let a = document.createElement('a');

    // setting new to do values
    label.innerHTML = todoText + " ";
    a.href = "#"
    a.onclick = delLi;
    a.innerHTML = 'Excluir';

    // add new to do
    li.appendChild(label);
    li.appendChild(a);
    ul.appendChild(li);

    // clear input
    elementInput.value = "";
}

// delete to do
function delLi() {
    li = this.parentNode;
    ul = li.parentNode;
    ul.removeChild(li);
}

// get ul and button elements
let ul = document.querySelector('ul');
let button = document.querySelector('#addTodo');
button.onclick = addTodo;