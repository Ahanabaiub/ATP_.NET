import React from 'react';
import { Doughnut } from 'react-chartjs-2';


import {
    Chart as ChartJS,
    CategoryScale,
    LinearScale,
    BarElement,
    Title,
    Tooltip,
    Legend,
    ArcElement
  } from 'chart.js';

  
  
  ChartJS.register(
    CategoryScale,
    LinearScale,
    BarElement,
    ArcElement,
    Title,
    Tooltip,
    Legend,
  );


const Donught=(props)=> {

    // ['rgba(232,99,132,1)',
    // 'rgba(232,211,6,1)',
    // 'rgba(54,162,235,1)',
    // 'rgba(255,159,64,1)',
    // 'rgba(153,102,255,1)' ]

    const data = {
        labels: props.labels,
        datasets: [
            {
                label: 'Attendance for Week 1',
                data: props.data,
                borderColor: ['rgba(255,206,86,0.2)'],
                backgroundColor: props.bgColors,
                pointBackgroundColor: 'rgba(255,206,86,0.2)',
            }
    
        ]
    }

    const options = {
        plugins: {
            title: {
                display: true,
                text: props.text,
                color:'blue',
                font: {
                    size:28
                },
                padding:{
                    top:25,
                    bottom:25
                },
                responsive:true,
                maintainAspectRatio: true,
                animation:{
                    animateScale: true,
                               }
            }
            
        }
    
    }


    return ( 
        <>
            <Doughnut data={data} options={options}/>
        </>
     );
}

export default Donught;