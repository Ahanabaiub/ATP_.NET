import React from 'react';

import {
    Chart as ChartJS,
    CategoryScale,
    LinearScale,
    BarElement,
    Title,
    Tooltip,
    Legend,
  } from 'chart.js';
  import { Bar } from 'react-chartjs-2';
  
  
  ChartJS.register(
    CategoryScale,
    LinearScale,
    BarElement,
    Title,
    Tooltip,
    Legend
  );
  





const CompareBarChart=(props)=> {

    
    const options = {
        responsive: true,
        plugins: {
          legend: {
            position: 'top',
          },
          title: {
            display: true,
            text: props.title
          },
        },
      };
      
      const labels = props.labels;
    
      
    
      const data = {
        labels,
        datasets: [
          {
            label: props.label1,
            data: props.data1,
            backgroundColor: props.color1,
          },
          {
            label: props.label2,
            data: props.data2,
            backgroundColor: props.color2,
          }
         
        ],
       
      };


    return ( 
        <>
            <Bar options={options} data={data} />
        </> 
    );
}


export default CompareBarChart;