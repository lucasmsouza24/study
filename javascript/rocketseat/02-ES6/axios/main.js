axios = require('axios');

class Api {

    static async getUserInfo(username) {
        const response = await axios.get(`https://api.github.com/users/${username}`);
        return response
    }

}

let data = Api.getUserInfo('diego3g');
console.log(data);