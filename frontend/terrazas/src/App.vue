<template>
  <div id="app">
    <v-app>
      <v-app-bar app color="primary" dark>
        <v-toolbar-title>Compañia de Agua Las terrazas</v-toolbar-title>
        <v-spacer></v-spacer>
        <v-btn text rounded>Inicio</v-btn>
        <v-btn text rounded>LogIn</v-btn>
      </v-app-bar>

      <v-content>
        <router-view></router-view>
      </v-content>
    </v-app>
  </div>
</template>


<script>
export default {
  name: "App",
  data() {
    return {};
  }
};
</script>
