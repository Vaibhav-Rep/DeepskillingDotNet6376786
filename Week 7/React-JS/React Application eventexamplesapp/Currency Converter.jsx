import React from 'react';
class CurrencyConvertor extends React.Component {

constructor(props) {

super(props);

this.state = {

rupees: '',

euros: null,

};

}


handleChange = (e) => {

this.setState({ rupees: e.target.value });

};


handleSubmit = () => {

const rupees = parseFloat(this.state.rupees);

const euroRate = 0.011; // 1 INR = 0.011 EUR (example rate)

const euros = (rupees * euroRate).toFixed(2);

this.setState({ euros });

};


render() {

return (

<div>

<h3>Currency Converter (INR ➜ EUR)</h3>

<input

type="number"

placeholder="Enter amount in Rupees"

value={this.state.rupees}

onChange={this.handleChange}

/>

{' '}

<button onClick={this.handleSubmit}>Convert</button>


{this.state.euros && (

<p>

Converted Amount in Euros: <strong>€{this.state.euros}</strong>

</p>

)}

</div>

);

}

}