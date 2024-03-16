import React from 'react';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import Header from './Header';
import BowlerList from './Bowler/BowlerList';

function App() {
  return (
    <div className="App">
      <Header title="Meet the Marlins and the Sharks! Two amazing bowling teams!" />
      <BowlerList />
    </div>
  );
}

export default App;
