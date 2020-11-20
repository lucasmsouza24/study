class Person {
    constructor(first_name, last_name, age, gender, interests) {
        this.first_name = first_name
        this.last_name = last_name
        this.age = age
        this.gender = gender

        // build interests
        this.interests = ""
        for(let i in interests) {
            // console.log(i, interests[i], interests.length - 1, i === interests.length - 1);
            if(i == 0) {
                this.interests += interests[i]
            } else if(i == interests.length - 1) {
                this.interests += " and " + interests[i]
            } else {
                this.interests += ", " + interests[i]
            }
        }

        this.name = first_name + " " + last_name
        this.bio = this.name + " is " + this.age + " years old. He likes " + this.interests
    }
}

class App {

    constructor() {
        this.persons = Array()
        this.button = document.querySelector("#btnSubmit");
        this.content = document.querySelector("#content-box");

        this.button.onclick = this.addPerson;
    }

    addPerson() {
        let first_name = document.querySelector("#first-name")
        let last_name = document.querySelector("#last-name")
        let age = document.querySelector("#age")
        let gender = document.querySelector("#gender")
        let interests = document.querySelector("#interests")
        
        let person = new Person(first_name.value, last_name.value, age.value, gender.value, interests.value.split(" "));
        
        
        app.persons.push(person)
        
        first_name.value = ''
        last_name.value = ''
        age.value = ''
        gender.value = ''
        interests.value = ''

        app.render()
    }

    render() {
        app.content.innerHTML = "";

        // build persons
        for(let i in app.persons) {
            let person_card = document.createElement('div')
            let first_name = document.createElement('p')
            let last_name = document.createElement('p')
            let age = document.createElement('p')
            let gender = document.createElement('p')
            let bio = document.createElement('p')

            person_card.setAttribute('class', 'person-card')
            first_name.innerHTML = app.persons[i].first_name
            last_name.innerHTML = app.persons[i].last_name
            age.innerHTML = app.persons[i].age
            gender.innerHTML = app.persons[i].gender
            bio.innerHTML = app.persons[i].bio

            person_card.appendChild(first_name)
            person_card.appendChild(last_name)
            person_card.appendChild(age)
            person_card.appendChild(gender)
            person_card.appendChild(bio)

            app.content.appendChild(person_card)
        }
    }
}

const app = new App();