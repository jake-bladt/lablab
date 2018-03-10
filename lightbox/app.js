(($, ko) => {
  let app = {};

  // Document ready
  $(() => {
    app.viewModel = mockViewModel;
    ko.applyBindings(app.viewModel);
  });

})(jQuery, ko);
