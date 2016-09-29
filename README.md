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
    <th>Original size</th>
    <th>Final Size</th>
  </thead>
  <tbody>
    <tr>
      <td>2.379.776 bytes</td>
      <td>45.056 bytes</td>
    </tr>
    <tr>
      <td>7.237.632 bytes</td>
      <td>139.264 bytes</td>
    </tr>
    <tr>
      <td>33.640.448 bytes</td>
      <td>45.056 bytes</td>
    </tr>
  </tbody>
</table>
