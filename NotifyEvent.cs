
namespace TileManager {
     class NotifyEvent : EventArgs {

         public string Text { get; private set; }

         public NotifyEvent(string text) {
             this.Text = text;
         }


         public string ControlName { get; private set; }
         public string Property { get; private set; }
         public string Value { get; private set; }

         public NotifyEvent(string controlName, string property, string value) {
             this.ControlName = controlName;
             this.Property = property;
             this.Value = value;
         }
     }
}
