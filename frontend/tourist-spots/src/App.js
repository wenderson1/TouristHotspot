import React, {useEffect, useState} from 'react';
import axios from 'axios';
import './App.css';

function App() {

  const [tourSpot, setTourSpot] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(()=>{
    axios.get("https://localhost:44386/api/tourSpot")
    .then((response)=>{
        console.log(response.data)
        setTourSpot(response.data);
        setLoading(false);
    }).catch(()=>{
        console.log("Moiou pai")
    })

  },[])

  if(loading){
   return(
     <div className='loading'>

        <div class="loadingio-spinner-spinner-3zmfkzkz4av"><div class="ldio-0jk03z39r549">
        <div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div>
        </div></div>

     </div>



   )
  }

  return (
    <div className="app">

			<div className="cards">

        {tourSpot.map((tourSpot,key)=>{
            return(
              <div className="card" key={key}>
              <div className="card-body" >
                <h1>{tourSpot.name}</h1>
                <div className="line"></div>
                <h2>{tourSpot.city}</h2>
                <h2>{tourSpot.state}</h2>
              </div>
            </div>
            )
        })}

        </div>
        </div>
  );
}

export default App;
