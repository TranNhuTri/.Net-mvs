var categoryItems = document.getElementsByClassName("category_item");
var typeProduct = new Map ([["Chó cảnh", 1], ["Mèo cảnh", 2], ["Cá cảnh", 3], ["Chim cảnh", 4]])
var productList = document.getElementById("productList");
function convertString(s)
{
    var l = 0, r = s.length - 1;
    while(s[l] == " " || s[l] == "\n")
    {
        l ++;
    }
    while(s[r] == " " || s[r] == "\n")
    {
        r--;
    }
    return s.substring(l, r + 1);
}

for(var i = 0; i < categoryItems.length; i++)
{
    categoryItems[i].addEventListener("click", function(e)
    {
        for(let j = 0; j < categoryItems.length; j++)
        {
            categoryItems[j].classList.remove("category_item--active");
        }
        e.target.classList.add("category_item--active");

        var xml = new XMLHttpRequest();
        xml.onreadystatechange = function()
        {
            if(this.readyState == 4 && this.status == 200)
            {
                var HTML = '<div class = "grid_row">';
                for(let j = 0; j < JSON.parse(xml.responseText).length; j++)
                {
                    if(j == 0)
                    {
                        HTML += `<div class="grid_column-10-2"><div class="product_item"> <div class="product_img" style="background-image: url(${JSON.parse(xml.responseText)[j].imgLink});"></div> <h3>${JSON.parse(xml.responseText)[j].describe}</h3> <div class="product_cost"> <span class="old_cost">9.000.000đ</span> <span class="new_cost">${JSON.parse(xml.responseText)[j].price}</span> </div> <div class="product_action"> <i class="far fa-heart"></i> <div class="product_rating"> <i class="far fa-star"></i> <i class="far fa-star"></i> <i class="far fa-star"></i> <i class="far fa-star"></i> <i class="far fa-star"></i> </div> </div> <div class="product_origin"> ${JSON.parse(xml.responseText)[j].origin} </div> <div class="product_favorite_label"> Yêu thích + </div> <div class="product_sale_label"> <p>50%</p> <h4>GIẢM</h4> </div> </div></div>`;
                        continue;
                    }
                    if(j % 4 == 0 && j != 0)
                    {
                        HTML += `<div class="grid_column-10-2"><div class="product_item"> <div class="product_img" style="background-image: url(${JSON.parse(xml.responseText)[j].imgLink});"></div> <h3>${JSON.parse(xml.responseText)[j].describe}</h3> <div class="product_cost"> <span class="old_cost">9.000.000đ</span> <span class="new_cost">${JSON.parse(xml.responseText)[j].price}</span> </div> <div class="product_action"> <i class="far fa-heart"></i> <div class="product_rating"> <i class="far fa-star"></i> <i class="far fa-star"></i> <i class="far fa-star"></i> <i class="far fa-star"></i> <i class="far fa-star"></i> </div> </div> <div class="product_origin"> ${JSON.parse(xml.responseText)[j].origin} </div> <div class="product_favorite_label"> Yêu thích + </div> <div class="product_sale_label"> <p>50%</p> <h4>GIẢM</h4> </div> </div></div>`;
                        HTML += '</div><div class = "grid_row">';
                    }
                    else
                        HTML += `<div class="grid_column-10-2"><div class="product_item"> <div class="product_img" style="background-image: url(${JSON.parse(xml.responseText)[j].imgLink});"></div> <h3>${JSON.parse(xml.responseText)[j].describe}</h3> <div class="product_cost"> <span class="old_cost">9.000.000đ</span> <span class="new_cost">${JSON.parse(xml.responseText)[j].price}</span> </div> <div class="product_action"> <i class="far fa-heart"></i> <div class="product_rating"> <i class="far fa-star"></i> <i class="far fa-star"></i> <i class="far fa-star"></i> <i class="far fa-star"></i> <i class="far fa-star"></i> </div> </div> <div class="product_origin"> ${JSON.parse(xml.responseText)[j].origin} </div> <div class="product_favorite_label"> Yêu thích + </div> <div class="product_sale_label"> <p>50%</p> <h4>GIẢM</h4> </div> </div></div>`;
                }
                HTML += "</div>"
                productList.innerHTML = HTML;
            }
        }
        xml.open("GET", `https://localhost:5001/home/danhsachsanpham/${typeProduct.get(convertString(e.target.textContent))}`, true);
        xml.send();
    }
    );
}
var productFilterButtons = document.getElementsByClassName("product_filter_btn");
for(i = 0; i < productFilterButtons.length; i++)
{
    productFilterButtons[i].addEventListener("click", function(e)
        {
            for(var j = 0; j < productFilterButtons.length; j++)
                productFilterButtons[j].classList.remove("button--active");
            e.target.classList.add("button--active");
        }
    );
}
