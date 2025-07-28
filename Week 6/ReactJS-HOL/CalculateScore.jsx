import React from 'react';

import './App.css';

import CalculateScore from './Components/CalculateScore';

function App() {

return (

<div className="App">

<CalculateScore name="Aniketh Reddy" school="Bharath University" total={480} goal={6} />

</div>

);

}
export default App;