//1
$('.first td').html('<p>текст у клітинці</p>');
$('.first td[colspan]').css('color', 'red');
$('.first td[rowspan]').css('font-size', '2em');

//2
$('.third td').html('<div>текст у клітинці</div>');
$('.third').css('background', 'blue');
$('.third tr:nth-child(3n)').css('font-style', 'italic');
$('.third tr').not('tr:nth-child(1), tr:nth-child(2), tr:nth-child(3)').css('text-transform', 'uppercase');

//3
$('.fourth tr:first-child() td').html('<pre>текст у клітинці</pre>');
$('.fourth tr:first-child() td:nth-child(2n)').css('color', 'green');
$('.fourth td:nth-child(3)').html('<hr>');
$('.fourth tr:last-child() td:first-child()').html(`<ul>
                                                        <li>1 рядок</li>
                                                        <li>2 рядок</li>
                                                        <li>3 рядок</li>
                                                        <li>4 рядок</li>
                                                    </ul>`);
$('.fourth tr:last-child() td:first-child() ul li').each(function(i, val) { alert($(this).text());});