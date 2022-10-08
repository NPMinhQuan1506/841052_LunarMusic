import React from "react";
import {
  BrowserRouter,
  Routes,
  Route,
} from "react-router-dom";
import CssBaseLine from "@mui/material/CssBaseline";

function App() {
  return (
    <>
      <CssBaseLine />
      <BrowserRouter>
      <h1>
        This is Presentation Tier of LunarMusic.
        Route in here
      </h1>
      </BrowserRouter>
    </>
  );
}

export default App;
