const port = 3003

const db = require('./db')
const bodyParser = require('body-parser')
const express = require('express')
const { deleteProduct } = require('./db')
const app = express()

app.use(bodyParser.urlencoded({ extended: true }))

app.get('/produtos', (req, res, next) => {
    res.send(db.getProducts())
})

app.get('/produtos/:id', (req, res, next) => {
    res.send(db.getProduct(req.params.id))
})

app.post('/produtos', (req, res, next) => {
    const product = db.saveProduct({
        name: req.body.name,
        price: req.body.price
    })
    res.send(product) // JSON
})

app.delete('/produtos/:id', (req, res, next) => {
    const product = db.deleteProduct(req.params.id)
    res.send(product) // JSON
})

app.listen(port, () => {
    console.log(`This server is running in port: ${port}`)
})