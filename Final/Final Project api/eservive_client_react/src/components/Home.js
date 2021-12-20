import axios from 'axios';
import React from 'react';
import { useEffect, useState } from 'react';
import {useHistory } from 'react-router-dom/cjs/react-router-dom.min';

import BarChart from './BarChart';
import CompareBarChart from './CompareBarChart';
import Donught from './Donught';



const Home = () => {

    let history = useHistory();

    const [totalCustomers, setTotalCustomers] = useState(0);
    const [totalOrders, setTotalOrders] = useState(0);
    const [totalEmployees, setTotalEmployees] = useState(0);
    const [totalServices, setTotalServices] = useState(0);
    const [serviceOrderData, setServiceOrderData] = useState(0);
    const [doughnutData, setDoughnutData] = useState([]);
    const [doughnutDataColor, setDoughnutDataColor] = useState([]);
    const [comparisonData1, setComparisonData1] = useState([]);
    const [comparisonData2, setComparisonData2] = useState([]);

    const bgColorsList = ['rgba(232,99,132,1)',
        'rgba(232,211,6,1)',
        'rgba(54,162,235,1)',
        'rgba(255,159,64,1)',
        'rgba(153,102,255,1)',
        '#8e24aa', '#8bc34a'];


    const getApiData = async () => {

        try {
            let resp = await axios.get('/api/customers/count');
            setTotalCustomers(resp.data);


            resp = await axios.get('api/orders/count');
            setTotalOrders(resp.data);


            resp = await axios.get('api/employee/count');
            setTotalEmployees(resp.data);

            resp = await axios.get('api/service/count');
            setTotalServices(resp.data);

            resp = await axios.get('api/service/service-order-data');
            setServiceOrderData(resp.data);

            resp = await axios.get('api/service/service-employee-data');
            setDoughnutData(resp.data);


            let len = Object.keys(resp.data).length;
            let colors = [];
            for (var i = 0; i < len; i++) {
                colors[i] = bgColorsList[i];
            }
            setDoughnutDataColor(colors);

            ///.....comparison data fetch..........
            let year = '2020';
            resp = await axios.get('/api/order/monthly/' + year);

            setComparisonData1(resp.data);

            year = '2021';
            resp = await axios.get('/api/order/monthly/' + year);

            setComparisonData2(resp.data);


        } catch (err) {
           
            history.push({
                pathname: '/',
                state: err.response.data
            });
        }


    }


    useEffect(() => {

        getApiData();

    }, []);




    return (
        <>
            <div className='container mt-3'>

                <div className='row'>
                    <div className='col-sm-3'>
                        <div className="card bg-warning shadow" style={{ width: "14rem", height: "11rem" }}>
                            <div className="card-body">
                                <h5 className="card-title">Customers</h5>
                                <p className="card-text mt-5 fs-1 h1">{totalCustomers}</p>

                            </div>
                        </div>
                    </div>
                    <div className='col-sm-3'>
                        <div className="card bg-info shadow" style={{ width: "14rem", height: "11rem" }}>
                            <div className="card-body">
                                <h5 className="card-title">Orders</h5>
                                <p className="card-text  mt-5 fs-1 h1">{totalOrders}</p>

                            </div>
                        </div>
                    </div>
                    <div className='col-sm-3'>
                        <div className="card bg-danger shadow " style={{ width: "14rem", height: "11rem" }}>
                            <div className="card-body">
                                <h5 className="card-title">Employee</h5>
                                <p className="card-text  mt-5 fs-1 h1">{totalEmployees}</p>

                            </div>
                        </div>
                    </div>
                    <div className='col-sm-3'>
                        <div className="card bg-danger shadow" style={{ width: "14rem", height: "11rem" }}>
                            <div className="card-body">
                                <h5 className="card-title">Services</h5>
                                <p className="card-text  mt-5 fs-1 h1">{totalServices}</p>

                            </div>
                        </div>
                    </div>
                </div>
                <div className='row mt-5 gx-5'>
                    <div className='col-md-6  card ' style={{ background: "" }}>
                        <div className='p-3'>
                            <BarChart title='Service -- Order Chart' color='#6200ea' label='Orders-service'
                                data={Object.values(serviceOrderData)} labels={Object.getOwnPropertyNames(serviceOrderData)} />
                        </div>

                    </div>
                    <div className='col-md-6 card p-4'>
                        <div className='p-3'>
                            <Donught labels={Object.getOwnPropertyNames(doughnutData)} data={Object.values(doughnutData)}
                                bgColors={doughnutDataColor} text='Service -- Worker' />
                        </div>
                    </div>
                </div>
                <div className='mt-4'>
                    <h1>Comparison of Orders</h1>
                    <div>
                        <CompareBarChart
                            title='Current and last year Comparison'
                            color1='rgba(54,162,235,1)'
                            color2='#8e24aa'

                            label1='2020'
                            label2='2021'

                            data1={Object.values(comparisonData1)}
                            data2={Object.values(comparisonData2)}

                            labels={Object.getOwnPropertyNames(comparisonData2)}


                        />
                    </div>
                </div>
                <div style={{ height: "200px" }}>

                </div>


            </div>
        </>
    );
}

export default Home;