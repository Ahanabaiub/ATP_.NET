import React from 'react';
import './Sidebar.css';


const Sidebar = () => {
    return (
        <>
            {/* <a className="btn btn-primary" data-bs-toggle="offcanvas" href="#offcanvasExample" role="button" aria-controls="offcanvasExample">
                <i class="bi bi-list"></i>
            </a> */}
            {/* <button className="btn btn-primary" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasExample" aria-controls="offcanvasExample">
                Button with data-bs-target
            </button> */}

            <div className="offcanvas offcanvas-start w-25 bg-dark text-white" tabIndex="-1" id="offcanvasExample" aria-labelledby="offcanvasExampleLabel">
                <div className="offcanvas-header">
                    <h5 className="offcanvas-title" id="offcanvasExampleLabel">Menu</h5>
                    <button type="button" className="btn-close text-reset bg-warning" data-bs-dismiss="offcanvas" aria-label="Close"></button>
                </div>
                <div className="offcanvas-body p-0">
                    <div>
                        <div className='p-3'>
                            <p className='h3 ms-2'>Manager Dashboard</p>
                        </div>
                        <hr className="dropdown-divider" />
                        <div className='mt-4 p-3'>
                            <div className='d-flex flex-column'>
                                <div className="p-2 side-menu-item">Customer</div>
                                <div className="p-2 side-menu-item">Delivery Man</div>
                                <div className="p-2 side-menu-item">Services</div>
                                <div className="p-2 side-menu-item">ReportsName</div>
                                
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </>
    );
}

export default Sidebar;