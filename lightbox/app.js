(($, ko) => {
  let app = {};

  // Document ready
  $(() => {
    console.log('App script loaded.');
    app.viewModel = mockViewModel;
    ko.applyBindings(viewModel);
  });

})(jQuery, ko);
