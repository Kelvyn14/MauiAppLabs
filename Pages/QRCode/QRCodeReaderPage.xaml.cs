
using ZXing.Net.Maui;

namespace MauiAppLabs.Pages.QRCode;

public partial class QRCodeReaderPage : ContentPage
{
  public QRCodeReaderPage()
  {
    InitializeComponent();
    ConfigureQrCodeReader();
    BindingContext = this;
  }

  private void ConfigureQrCodeReader()
  {
    cameraBarcodeReaderView.Options = new BarcodeReaderOptions
    {
      Formats = BarcodeFormat.QrCode,
      AutoRotate = true,
      Multiple = true
    };

    //Toggle Torch
    //cameraBarcodeReaderView.IsTorchOn = !cameraBarcodeReaderView.IsTorchOn;

    //Flip between Rear/Front cameras
    //cameraBarcodeReaderView.CameraLocation =
    //  cameraBarcodeReaderView.CameraLocation == CameraLocation.Rear ? CameraLocation.Front : CameraLocation.Rear;
  }

  protected void BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
  {
    //foreach (var barcode in e.Results)
    //  Console.WriteLine($"Barcodes: {barcode.Format} -> {barcode.Value}");

    var first = e.Results?.FirstOrDefault();

    if (first is null) return;

    Dispatcher.DispatchAsync(async () =>
    {
      await DisplayAlert("QR Code Detectado: ", first.Value, "OK");
    });
  }
}