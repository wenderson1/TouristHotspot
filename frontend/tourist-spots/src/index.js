import React from 'react';
import ReactDOM from 'react-dom';
import App from './App';
import Create from './components/Create/Create';
import {BrowserRouter} from 'react-router-dom'

ReactDOM.render(
  <BrowserRouter>
    <App />
    <Create />
  </BrowserRouter>,
  document.getElementById('root')
);
