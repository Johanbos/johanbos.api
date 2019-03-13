<template>
  <div class="content">
    <h2>Events</h2>
    <div class="event" v-for="(event, index) in sorted" :key="index">
      <i class="type" :class="event.type | icon" />{{event.title}}<span class="date">{{event.date}}{{event.timespan | wrap}}</span>
      <CollapseContainer>
        <span class="story">{{event.story}}</span>
        <a class="reference" :href="event.reference" target="_blank">{{event.reference}}</a>
      </CollapseContainer>
    </div>
  </div>
</template>

<script>
import events from "../data/events";
import CollapseContainer from "./CollapseContainer.vue";

export default {
  name: "MyEvents",
  components: {
    CollapseContainer
  },
  props: {},
  data() {
    return {
      events: events,
      sortKey: "Date",
      reverse: false
    };
  },
  computed: {
    sorted: function() {
      return events.specials.sort(function(a, b) {
        return a.type.localeCompare(b.type);
      });
    }
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
.event {
  margin-top: 0.3em;
}
.date {
  float: right;
}
.icon {
  width: 1.2em;
}
.story {
  clear: left;
  margin: 0.5em 0;
}
.type {
  margin-right: 0.3em;
}
.reference {
  clear: both;
  display: block;
  margin: 0.3em 0;
}
</style>