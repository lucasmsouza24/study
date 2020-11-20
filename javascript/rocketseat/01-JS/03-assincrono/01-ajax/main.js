let xhr = new XMLHttpRequest();

xhr.open('GET', 'https://api.github.com/users/mesquitakkk');
xhr.send(null);

xhr.onreadystatechange = function() {
    if (xhr.readyState === 4) {
        let data = JSON.parse(xhr.responseText);
        for(i in data) {
            // console.log(`${i}: ${data[i]}`);
            console.log(data.name);
        }
    }
}