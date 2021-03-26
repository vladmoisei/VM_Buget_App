import { BrowserRouter, Routes, Route } from "react-router-dom";
import "./App.css";
import { Home } from "./Pages/Home";
import { Counter } from "./Components/Counter";
import { FetchData } from "./Pages/FetchData";
import { Layout } from "./Components/Layout";

function App() {
  return (
    <BrowserRouter>
      <Layout>
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/fetchdata" element={<FetchData />} />
          <Route path="/counter" element={<Counter />} />
          <Route path="" element
        </Routes>
      </Layout>
    </BrowserRouter>
  );
}

export default App;
