const express = require('express');
const app = express();
const cors = require('cors');
const fs = require('fs-extra');

const port = 8000
app.use(express.json());
app.use(express.urlencoded({ extended: true }));


// האפשרות לקבל קריאה מכל קליינט שהוא
app.use(cors());

const getTasks = () => {
    const tasks = require('./tasks.json');
    console.log('--- tasks: ' + JSON.stringify(tasks));
    return tasks;
}


let baseId =[...getTasks()].pop()?.id || 1;
const getId = () => ++baseId;

app.get('/tasks', (req, res) => {
  return res.send(getTasks());
});

app.get('/tasks/:id', (req, res) => {
    const id = req.params.id;
    return res.send(getTasks().find(t => t.id === parseInt(id)));
  });

app.post('/tasks', async (req, res) => {
    const { description } = req.body;
    const newTask = {
        description,
        done: false,
        id: getId(),
    };
    const tasks = getTasks();
    tasks.push(newTask);
    try {
        await fs.writeJson(__dirname + '/tasks.json', tasks);
        console.log('success!')
    } catch (err) {
        console.error(err)
    }
    res.send();
});

app.delete('/tasks/:id', async (req, res) => {
    const id = parseInt(req.params.id);
    const tasks = getTasks();
    const index = tasks.findIndex(t => t.id === id);
    tasks.splice(index, 1);
    try {
        await fs.writeJson(__dirname + '/tasks.json', tasks);
        console.log('success!')
    } catch (err) {
        console.error(err)
    }
    res.send('success');
})

app.delete('/task_complete', async (req, res) => {
    const tasks = getTasks();
    const undoneTasks = tasks.filter(t => !t.done);
    tasks.splice(0, tasks.length);
    tasks.push(...undoneTasks);
    try {
        await fs.writeJson(__dirname + '/tasks.json', undoneTasks);
        console.log('success!')
    } catch (err) {
        console.error(err)
    }
    res.send('success');
})

app.put('/tasks/:id', async (req, res) => {
    const id = parseInt(req.params.id);
    const tasks = getTasks();
    const task = tasks.find(t => t.id === id);
    const { description, done } = req.body;
    if (description) {
        task.description = description;
    }
    if (typeof done !== 'undefined') {
        task.done = done;
    }
    try {
        await fs.writeJson(__dirname + '/tasks.json', tasks);
        console.log('success!')
    } catch (err) {
        console.error(err)
    }
    res.send('success');
})



app.listen(port, () => {
  console.log(`Example app listening at http://localhost:${port}`)
});