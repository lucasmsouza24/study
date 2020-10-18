const concepts = (array) => {
    let concepts_array = Array()
    for (let i in array) {
        if (array[i] >= 9 && array[i] <= 10) {
            concepts_array.push("A")
        } else if (array[i] >= 7 && array[i] <= 8.9) {
            concepts_array.push("B")
        } else if (array[i] >= 5 && array[i] <= 6.9) {
            concepts_array.push("C")
        } else if (array[i] >= 0 && array[i] <= 4.9) {
            concepts_array.push("D")
        } else {
            return null
        }
    }
    return concepts_array
}

console.log(concepts([10, 8, 0, 7]))