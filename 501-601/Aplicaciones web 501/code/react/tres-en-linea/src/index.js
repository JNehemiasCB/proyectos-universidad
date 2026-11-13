import React from 'react';
import './App.css';
import ReactDOM from 'react-dom/client';
import './index.css';
import Game from './App.jsx';


const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <Game />
  </React.StrictMode>
);
