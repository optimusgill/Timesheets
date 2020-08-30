import React, { useEffect, useState } from "react";

export default function ProjectsList() {
  const [count, setcount] = useState(0);
  function increment() {
    setcount((prevCount) => prevCount + 1);
  }
  function decrement() {
    setcount((prevCount) => prevCount - 1);
  }

  const dec = () => {
    setcount((prevCount) => prevCount - 1);
  };
  useEffect(() => {
    console.log("here");
  }, [count]);
  return (
    <div>
      <button onClick={increment}>+</button>
      <span>{count}</span>
      <button onClick={dec}>-</button>
    </div>
  );
}
