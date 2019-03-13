<template>
  <div class="inline">
    <span class="more">{{toggle}}</span>
    <div class="content" v-if="open">
      <slot />
    </div>
  </div>
</template>

<script>
export default {
  name: "CollapseContainer",
  props: {},
  data() {
    return {
      open: false
    };
  },
  computed: {
    toggle: function() {
      if (open) {
        return "show less";
      }
      return "read more";
    }
  }
};
</script>

<style scoped>
.inline {
  display: inline;
}
.more {
  color: gray;
  margin: 0 0.5em;
}
.content {
  margin: 0.5em 0;
}
</style>