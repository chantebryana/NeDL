const express = require('express');
const app = express();

//middleware for post method
app.use(express.json());

const courses = [
    { id: 1, name: 'course1' }, 
    { id: 2, name: 'course2' }, 
    { id: 3, name: 'course3' }
];

app.get('/', (req, res) => {
    res.send('hello world!!!');
});

app.get('/api/courses', (req, res) => {
    res.send(courses);
});

// /api/courses/1
app.get('/api/courses/:id', (req, res) => {
    const course = courses.find(c => c.id === parseInt(req.params.id));

    if (!course) {
        res.status(404).send('The course with the given ID was not found.');
    } else {
        res.send(course);
    }
});

app.post('/api/courses', (req, res) => {
    //invalid input validation
    if (!req.body.name || req.body.name.length < 3) {
        //400 bad request
        res.status(400).send('Name is required and should be at least 3 characters.');
        return;
    }
    const course = {
        id: courses.length + 1,
        name: req.body.name
    };
    courses.push(course);
    res.send(course);
});

app.put('/api/courses/:id', (req, res) => {
    //look up course
    //if doesn't exist, return 404
    const course = courses.find(c => c.id === parseInt(req.params.id));

    if (!course) {
        res.status(404).send('The course with the given ID was not found.');
    } 

    //else, validate
    //if invalid, return 400 (bad request)

    //update course
    course.name = req.body.name;

    //return the updated course to client
    res.send(course);

});

app.delete('/api/courses/:id', (req, res) => {
    //look up course
    //if doesn't exist, return 404
    const course = courses.find(c => c.id === parseInt(req.params.id));

    if (!course) {
        res.status(404).send('The course with the given ID was not found.');
    }

    //if course found, delete it
    const index = courses.indexOf(course);
    courses.splice(index, 1);

    //return the same course (the course that was deleted)
    res.send(course);
});

//PORT
//in terminal: \express-demo>set PORT=5000
const port = process.env.PORT || 3000;

app.listen(port, () => {
    console.log(`listening on port ${port}...`);
});