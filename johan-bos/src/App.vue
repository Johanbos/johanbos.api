<template>
  <div id="app">
    <img alt="Vue logo" src="./assets/logo.png">
    <main>
      <h1>Johan Bos</h1>
      <p>Hi there! Welcome to my Continuous Improvement trackrecord.</p>
      <MyEvents/>
    </main>
  </div>
</template>

<script>
import MyEvents from "./components/MyEvents.vue";

export default {
  name: "app",
  components: {
    MyEvents
  }
};
</script>

<style>
body {
  background: linear-gradient(to bottom right, white, green);
  background-attachment: fixed;
}

#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  padding: 5px;
  background: white;
}
</style>
