import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import { Container } from 'react-bootstrap'
import NavBarEdunova from './components/NavBarEdunova'
import { Route, Routes } from 'react-router-dom'
import { RouteNames } from './constants'
import Pocetna from './pages/Pocetna'
import ProdavateljiPregled from './pages/prodavatelji/ProdavateljiPregled'


function App() {
  

  return (
    <Container>
      <NavBarEdunova />
<Container className="app">
  <Routes>
        <Route path={RouteNames.HOME} element={<Pocetna />} />

        <Route path={RouteNames.PRODAVATELJ_PREGLED} element={<ProdavateljiPregled />} />
        
      </Routes>
      </Container>

      <hr />
      &copy; Zlatko
    </Container>
  )
}

export default App
