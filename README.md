# ResizeImageClientSize
This proyect is a sample to process a large image and send Server Side resized and compressed.

<h3>Client Side</h3>
<p>Using the HTML5's canvas object, when a file is picked from a input[file] via JavaScript is rendered. </p>
<p>When you press the save button, by Jquery post the value of canvas object converted to a JPEG image.</p>
<br />
<h3>Server Side</h3>
In the <i>Images</i>Controller, there is a Create Action receing a random param called <i>description</i> and a second parameter called image containing the binary data of the image from then client side. Now, we can convert this data to a physical file writing with a BynaryWriter.

<h2>Conclusion</h2>
<table>
  <thead>
    <th>Sample image</th>
    <th>Original size</th>
    <th>Final Size</th>
  </thead>
  <tbody>
    <tr>
    <td>
<a data-flickr-embed="true" data-footer="true"  href="https://www.flickr.com/photos/sagadegeminis/22923861403/in/album-72157659750964293/" title="_DSC0967"><img src="https://c4.staticflickr.com/1/621/22923861403_44453e0c05_m.jpg" width="240" height="159" alt="_DSC0967"></a><script async src="//embedr.flickr.com/assets/client-code.js" charset="utf-8"></script>
    </td>
      <td>2.379.776 bytes</td>
      <td>45.056 bytes</td>
    </tr>
    <tr>
        <td>
<a data-flickr-embed="true" data-header="true" data-footer="true"  href="https://www.flickr.com/photos/sagadegeminis/29199512430/in/album-72157670245253793/" title="_DSC5362.jpg"><img src="https://c7.staticflickr.com/9/8298/29199512430_28d9908af7_m.jpg" width="240" height="159" alt="_DSC5362.jpg"></a><script async src="//embedr.flickr.com/assets/client-code.js" charset="utf-8"></script>
        </td>
      <td>7.237.632 bytes</td>
      <td>139.264 bytes</td>
    </tr>
    <tr>
      <td>
      <a data-flickr-embed="true" data-header="true" data-footer="true"  href="https://www.flickr.com/photos/sagadegeminis/29454594566/in/album-72157670245253793/" title="Liceo Aeronáutico Militar"><img src="https://c7.staticflickr.com/9/8266/29454594566_fec2684085_m.jpg" width="240" height="40" alt="Liceo Aeronáutico Militar"></a><script async src="//embedr.flickr.com/assets/client-code.js" charset="utf-8"></script>
      </td>
      <td>33.640.448 bytes</td>
      <td>45.056 bytes</td>
    </tr>
  </tbody>
</table>
