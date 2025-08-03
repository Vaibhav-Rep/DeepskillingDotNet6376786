import React from 'react';

import CurrencyConvertor from './CurrencyConvertor';


class App extends React.Component {

constructor(props) {

super(props);

this.state = {

counter: 0,

};

}


// Increments counter

handleIncrement = () => {

this.setState(prevState => ({

counter: prevState.counter + 1,

}));

this.sayHello();

};


// Decrements counter

handleDecrement = () => {

this.setState(prevState => ({

counter: prevState.counter - 1,

}));

};


// Say Hello

sayHello = () => {

console.log("Hello! Button clicked.");

alert("Hello! You just increased the count.");

};


// Say Welcome with parameter

sayWelcome = (message) => {

alert(message);

};


// Synthetic Event handler

handleClick = (e) => {

alert("I was clicked!");

console.log("Synthetic event object:", e);

};


render() {

return (

<div style={{ padding: "20px", fontFamily: "Arial" }}>

<h2>Event Examples App</h2>


<h3>Counter: {this.state.counter}</h3>

<button onClick={this.handleIncrement}>Increment</button>{' '}

<button onClick={this.handleDecrement}>Decrement</button>


<hr />


<button onClick={() => this.sayWelcome("Welcome to React Events!")}>

Say Welcome

</button>


<hr />


<button onClick={this.handleClick}>Click Me (Synthetic Event)</button>


<hr />


<CurrencyConvertor />

</div>

);

}

}