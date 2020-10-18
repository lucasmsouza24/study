const comparaStrings = (str1, str2) => {
    str1 = str1.toUpperCase()
    str2 = str2.toUpperCase()
    let exists = true
    for (let i in str1) {
        for (let j in str2) {
            if (str1[i] == str2[j]) {
                break
            } else if (j == str2.length - 1) {
                exists = false
                break
            }
        }
    }
    return exists
}

console.log(comparaStrings("ab", "lucb"))

