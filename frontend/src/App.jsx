import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import { Container } from 'react-bootstrap'
import NavBarEdunova from './components/NavBarEdunova'
import { Route, Routes } from 'react-router-dom'
import { RouteNames } from './constants'
import Pocetna from './pages/Pocetna'
import SmjeroviPregled from './pages/prodavatelji/ProdavateljiPregled'
import ProdavateljiPregled from './pages/prodavatelji/ProdavateljiPregled'


function App() {
  

  return (
    <Container>
      <NavBarEdunova />

      <Routes>
        <Route path={RouteNames.HOME} element={<Pocetna />} />

        <Route path={RouteNames.PRODAVATELJ_PREGLED} element={<ProdavateljiPregled />} />
        
      </Routes>
      <hr />
      &copy; Zlatko
    </Container>
  )
}

export default App
