<template>
  <div class="content">
    <h2>Events</h2>
    <table>
      <thead>
        <tr>
          <td class="icon">Title</td>
          <td class="title"></td>
          <td>Date</td>
          <td>Reference</td>
        </tr>
      </thead>
      <tbody>
        <tr v-for="(event, index) in events.specials" :key="index" >
          <td><i :class="event.type | icon" /></td>
          <td>{{event.title}}</td>
          <td>{{event.date}} {{event.timespan | wrap}}</td>
          <td><a :href="event.reference" target="_blank" class="truncate">{{event.reference}}</a></td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
import events from "../data/events";

export default {
  name: "MyEvents",
  props: {},
  data() {
    return {
      events
    };
  },
  methods: {
    sortBy: function(sortKey) {
      this.reverse = this.sortKey == sortKey ? !this.reverse : false;
      this.sortKey = sortKey;
    }
  },
  filters: {
    icon: function(value) {
      switch (value) {
        case "Job":
          return "fas fa-building";
        case "Training":
          return "fas fa-book-reader";
        default:
          return "fas fa-question";
      }
    },
    wrap: function(value) {
      if (value) return " (" + value + ")";
      return "";
    }
  }
};
</script>

<style scoped>
h2 {
  margin: 40px 0 0;
}
a {
  color: green;
}
table {
  width: 100%;
  table-layout: fixed;
}
.icon {
  width: 1.2em;
}
.title {
  width: 40%;
}
.truncate {
  white-space: nowrap;
  overflow: hidden;
  text-overflow: ellipsis;
  display: block;
}
</style>