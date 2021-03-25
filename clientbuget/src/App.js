import { BrowserRouter, Routes, Route } from "react-router-dom";
import "./App.css";
import { Home } from "./Pages/Home";
import { FetchData } from "./Pages/FetchData";

function App() {
  return (
    <BrowserRouter>
      <div>
        <Routes>
          <Route path="" element={<Home />} />
          <Route path="fetchdata" element={<FetchData />} />
        </Routes>
      </div>
    </BrowserRouter>
  );
}

export default App;
